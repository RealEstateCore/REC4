[Point](../../Point.md) > [Parameter](../Parameter.md) > [Limit](Limit.md) > [Ventilation_Air_Flow_Ratio_Limit](.)
# Ventilation_Air_Flow_Ratio_Limit
**DTMI:** dtmi:org:brickschema:schema:Brick:Ventilation_Air_Flow_Ratio_Limit;1
## Display name
- **en:** Ventilation Air Flow Ratio Limit
## Description
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