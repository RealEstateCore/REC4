[Point](../../../Point.md) > [Sensor](../../Sensor.md) > [Flow_Sensor](../Flow_Sensor.md) > [Water_Flow_Sensor](Water_Flow_Sensor.md) > [Bypass_Water_Flow_Sensor](#)
# Bypass_Water_Flow_Sensor

**Display name:** Bypass Water Flow Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Bypass_Water_Flow_Sensor;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
