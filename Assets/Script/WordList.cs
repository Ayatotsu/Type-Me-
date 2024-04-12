using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random=UnityEngine.Random;


public class WordList : MonoBehaviour
{

    private List<string> words = new List<string>()
    {
        "2d", "3d", "sprite" ,"projection", "body" ,"joint" , "physics" ,"material", "ad", "start",
        "object", "navmesh", "active", "inactive", "user", "average", "revenue", "f2p", "whale", "spender",
        "events", "analytics", "application", "version", "daily", "users", "convert", "custom", "data",
        "demographics", "dolphins", "geography", "heatmaps", "purchase", "lifetime", "monthly", "annual",
        "minnow", "never", "monetized", "new", "number", "verify", "percentage", "remote", "settings",
        "segment", "session", "standard", "total", "time", "unity", "unknown", "gender", "blend",
        "animation", "shape", "tree", "clip", "node", "compression", "curves", "layer", "parameters",
        "state", "machine", "transition", "component", "controller", "override", "window", "avatar",
        "mask", "bind", "pose", "transform", "direct", "forward", "kinematics", "human", "template",
        "humanoid", "inverse", "keyframe", "reduction", "loop", "muscle", "play", "graph", "playables",
        "rig", "rigging", "root", "motion", "scene", "skinnings", "navigation", "target", "matching",
        "translate", "degree", "freedom", "asset", "package", "store", "model", "file", "prefab", "unit",
        "manager", "audio", "distortion", "filter", "effect", "high", "low", "pass", "listener", "source",
        "doppler", "dry", "level", "mix", "awake", "build", "plug-in", "development", "anchor", "console",
        "window", "flythrough", "mode", "input", "inspector", "player", "setting", "drawer", "property",
        "view", "zoom", "key", "category", "shading", "extrapolate", "extrapolation", "fps", "fbx", "game",
        "gameobject", "ignore", "interpolate", "interpolation", "layer", "marker", "parent", "profiler",
        "project", "component", "velocity", "vsync", "viewport", "world", "ambient", "light", "occlusion",
        "antialiasing", "aspect", "ratio", "baked", "lights", "billboard", "blit", "bloom", "bump", "map",
        "camera", "clipping", "plane", "cubemap", "culling", "depth", "buffer", "field", "distance",
        "shadowmask", "dynamic", "batching", "resolution", "enlighten", "exponential", "fog", "exposure",
        "value", "extrude", "edges", "far", "plane", "forward", "rendering", "render", "backward", "frame",
        "frames", "second", "frustum", "cache", "gizmo", "illumination", "gravity", "modifier", "halo", "hard",
        "shadows", "hdr", "hdri", "heightmap", "budget", "quality", "irradiance", "lens", "flare", "detail",
        "light", "probe", "group", "proxy", "volume", "line", "lod", "mesh", "filter", "renderer", "near",
        "normal", "culling", "orthographic", "particle", "system", "physical", "based", "pixel", "log", "post",
        "processing", "pseudo", "quad", "quaternion", "rasterization", "ray", "tracing", "realtime", "reflection",
        "pipeline", "texture", "path", "variant", "shader", "shaderlab", "shadowmask", "soft", "shadows", "spatial",
        "mapping", "specular", "color", "highlight", "packer", "batching", "receiver", "buffer", "static", "stencil",
        "surface", "terrain", "text", "import", "export", "tile", "tilemap", "tonemapping", "trail", "vector", "vertex",
        "video", "voxel", "webgl", "wind", "zone", "mixed", "identity", "network", "host", "networking", "built-in",
        "bundled", "default", "direct", "dependency", "embedded", "feature", "git", "immutable", "indirect", "local",
        "manifest", "mutable", "preview", "project", "verified", "profiler", "counter", "sample", "vblank", "call",
        "overhead", "bounding", "volume", "box", "collider", "capsule", "center", "character", "cloth", "collision",
        "detection", "configurable", "constant", "constraints", "damping", "discrete", "friction", "fixed", "timestep",
        "limit", "twist", "hinge", "physics", "engine", "rigidbody", "self", "sphere", "spring", "swing", "axis",
        "wheel", "terrain", "android", "debug", "bridge", "ahead", "format", "augmented", "reality", "closed", "open",
        "gradle", "keystone", "photo", "progressive", "razor", "virtual", "trace", "xr", "scripts", "tag", "test",
        "automation", "services", "canvas", "group", "image", "interactable", "ui", "raw", "scroll", "textfield",
        "toggle", "toolbar", "visual", "element"
    };

    private List<string> workingWords = new List<string>();

    private void Awake()
    {
        workingWords.AddRange(words);
        Shuffle(workingWords);
        ConvertToLower(workingWords);
    }

    private void Shuffle(List<string> lists) 
    {
        for (int i = 0; i < lists.Count; i++) 
        {
            int random = Random.Range(i, lists.Count);
            string temporary = lists[i];

            
            lists[i] = lists[random];
            lists[random] = temporary;
                
        }
    }

    private void ConvertToLower(List<string> lists) 
    {
        for (int i = 0; i < lists.Count; i++)
            lists[i] = lists[i].ToLower();
    }

    public string GetWord() 
    {
        string newWord = string.Empty;
        if (workingWords.Count != 0) 
        {
            newWord = workingWords.Last();
            workingWords.Remove(newWord);
        }
        
        return newWord;
    }
}
