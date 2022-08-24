[Point](../../Point.md) > [Sensor](../Sensor.md) > [Adjust_Sensor](Adjust_Sensor.md) > [Warm_Cool_Adjust_Sensor](.)
# Warm_Cool_Adjust_Sensor

**Display name:** Warm Cool Adjust Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Warm_Cool_Adjust_Sensor;1

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
